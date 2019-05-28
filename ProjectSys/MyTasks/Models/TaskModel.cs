using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyTasks.Models
{
    public class TaskModel
    {

        public TaskModel()
        {
            this.relatorio = new List<relatorio>();
        }
        public int Id { get; set; }
        [Display(Name = "Título")]
        public string Title { get; set; }
        [Display(Name = "Data Conclusão")]
        public string DueDate { get; set; }
        [Display(Name = "Importância")]
        public string Importance { get; set; }
        public string Status { get; set; }
        public int ProjectId { get; set; }
        public virtual ICollection<relatorio> relatorio { get; set; }
    }

    public class relatorio
    {
    }
}