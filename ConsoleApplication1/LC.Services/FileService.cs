using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC.Repositories.Implementations;
using Domain = LC.Domain;
using Dto = LC.Dto;

namespace LC.Services
{
    public class FileService
    {
        public FileRepository fileRepository { get; set; }

        public FileService()
        {
            this.fileRepository = new FileRepository();
        }

        public string GetFileFolderLocation(Dto.FilesDto file)
        {
            return file.Location.Replace($"\\{file.Name}", string.Empty);
        }

        public void DeleteFile(Guid key)
        {
            this.fileRepository.Delete(key);
        }

        public List<Dto.FilesDto> MapFileInfo(List<FileInfo> fileInfos)
        {
            List<Dto.FilesDto> result = new List<Dto.FilesDto>();

            foreach (var file in fileInfos)
            {
                result.Add(new Dto.FilesDto()
                {
                    Key = Guid.NewGuid(),
                    Location = file.FullName,
                    Extension = file.Extension,
                    Name = file.Name
                });
            }

            return result;
        }

        public Domain.Files MapToDomain(Dto.FilesDto filesDto)
        {
            return new Domain.Files()
            {
                Extension = filesDto.Extension,
                Key = filesDto.Key,
                Location = filesDto.Location,
                Name = filesDto.Name,
                Rename = filesDto.Rename
            };
        }

        public List<Domain.Files> MapToDomain(List<Dto.FilesDto> filesDto)
        {
            return filesDto.Select(f => new Domain.Files()
            {
                Extension = f.Extension,
                Key = f.Key,
                Location = f.Location,
                Name = f.Name,
                Rename = f.Rename
            }).ToList();
        }

        public Dto.FilesDto MapToDto(Domain.Files filesDomain)
        {
            return new Dto.FilesDto()
            {
                Extension = filesDomain.Extension,
                Key = filesDomain.Key,
                Location = filesDomain.Location,
                Name = filesDomain.Name,
                Rename = filesDomain.Rename
            };
        }

        public List<Dto.FilesDto> MapToDto(List<Domain.Files> filesDomain)
        {
            return filesDomain.Select(f => new Dto.FilesDto()
            {
                Extension = f.Extension,
                Key = f.Key,
                Location = f.Location,
                Name = f.Name,
                Rename = f.Rename
            }).ToList();
        }
    }
}
