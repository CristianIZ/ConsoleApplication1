using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LC.UserInterface
{
    public enum MessageEnum : int
    {
        [StringValue("Debe seleccionar un item de la lista de perfiles")]
        SelectedProfileListError = 1,

        [StringValue("Debe seleccionar un item de la lista de archivos")]
        SelectedFileListError = 2,
        
        [StringValue("Copiado con exito")]
        SuccesfullyCopied = 3,

        [StringValue("Proceso cancelado")]
        AbortedProcess = 4,

        [StringValue("Algunos archivos seleccionados ya no existen, si procede se eliminaran los registros de los archivos inexistentes")]
        DeleteMissingFilesDecition = 5,

        [StringValue("Guardado con exito")]
        SuccesfullySaved = 6,
    }
}
