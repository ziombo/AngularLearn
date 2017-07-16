using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{
    public class ModelResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}