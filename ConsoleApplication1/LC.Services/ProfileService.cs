using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain = LC.Domain;
using Dto = LC.Dto;
using LC.Repositories.Implementations;

namespace LC.Services
{
    public class ProfileService
    {
        public string ProfileFilesPath { get; set; }
        public ProfileRepository Repo { get; set; }
        public FileService fileService { get; set; }

        public ProfileService()
        {
            Repo = new ProfileRepository();

            this.ProfileFilesPath = FileManager.GetLocalPath();
            this.fileService = new FileService();
        }

        public IEnumerable<Dto.ProfileDto> GetAll()
        {
            return MapToDto(Repo.GetAll().ToList());
        }

        public Dto.ProfileDto GetByKey(Guid key)
        {
            return MapToDto(Repo.GetByKey(key));
        }

        public Domain.Profile GetDomainByKey(Guid key)
        {
            return Repo.GetByKey(key);
        }

        public Dto.ProfileDto Add(string name, string description)
        {
            var profile = new Domain.Profile()
            {
                Name = name,
                Key = Guid.NewGuid(),
                Description = description,
            };

            var result = Repo.Add(profile);
            Repo.Complete();
            return MapToDto(result);
        }

        public Dto.ProfileDto Update(Dto.ProfileDto profile)
        {
            var result = Repo.Update(MapToDomain(profile));
            Repo.Complete();
            return MapToDto(result);
        }

        public void Delete(Dto.ProfileDto profile)
        {
            Repo.Delete(MapToDomain(profile));
            Repo.Complete();
        }

        public Dto.ProfileDto SetRename(Dto.ProfileDto profileDto)
        {
            var profile = GetDomainByKey(profileDto.Key);

            foreach (var file in profile.Files)
            {
                if (file.Id == 0)
                    throw new Exception("Alguno de los archivos no posee id");

                file.Rename = file.Id.ToString();

                profileDto.Files.Where(f => f.Key == file.Key).Single().Rename = file.Rename;
            }

            return profileDto;
        }

        public void BackUpProfileFiles(Dto.ProfileDto profile)
        {
            var destinyFolder = GetProfileFolder(profile);

            if (FileManager.FolderExists(destinyFolder))
                FileManager.DeleteFolder(destinyFolder);

            FileManager.CreateDirectory(destinyFolder);

            foreach (var file in profile.Files)
            {
                FileManager.Copy(file.Location, destinyFolder, $"{file.Rename}{file.Extension}", true);
            }
        }

        public void RestoreProfileFiles(List<FileInfo> files, Dto.ProfileDto profile)
        {
            var sourceFolder = GetProfileFolder(profile);

            foreach (var file in files)
            {
                foreach (var dtoFile in profile.Files)
                {
                    if (file.Name == $"{dtoFile.Rename}{dtoFile.Extension}")
                    {
                        FileManager.Copy(file.FullName, FileManager.GetRootFileDirectory(dtoFile.Location), $"{dtoFile.Name}", true);
                        break;
                    }
                }
            }
        }

        public string GetProfileFolder(Dto.ProfileDto profile)
        {
            return $"{ProfileFilesPath}{profile.Name}";
        }

        private Domain.Profile MapToDomain(Dto.ProfileDto profileDto)
        {
            return new Domain.Profile()
            {
                Description = profileDto.Description,
                Key = profileDto.Key,
                Name = profileDto.Name,
                Files = profileDto.Files != null ? fileService.MapToDomain(profileDto.Files) : null
            };
        }

        private List<Domain.Profile> MapToDomain(List<Dto.ProfileDto> profileDto)
        {
            return profileDto.Select(p => new Domain.Profile()
            {
                Description = p.Description,
                Key = p.Key,
                Name = p.Name,
                Files = p.Files != null ? fileService.MapToDomain(p.Files) : null
            }).ToList();
        }

        private Dto.ProfileDto MapToDto(Domain.Profile profileDomain)
        {
            return new Dto.ProfileDto()
            {
                Description = profileDomain.Description,
                Key = profileDomain.Key,
                Name = profileDomain.Name,
                Files = profileDomain.Files != null ? fileService.MapToDto(profileDomain.Files) : null
            };
        }

        private List<Dto.ProfileDto> MapToDto(List<Domain.Profile> profileDomain)
        {
            return profileDomain.Select(p => new Dto.ProfileDto()
            {
                Description = p.Description,
                Key = p.Key,
                Name = p.Name,
                Files = p.Files != null ? fileService.MapToDto(p.Files) : null
            }).ToList();
        }
    }
}
