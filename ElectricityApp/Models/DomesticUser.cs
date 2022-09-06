
using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ElectricityApp.Models
{
    [Serializable]
    public class DomesticUser
    {
        [Key]
        
        [Name("TINKLAS")]
        public string Network { get; set; }

        [Name("OBT_PAVADINIMAS")]
        public string ObjName { get; set; }

        [Name("OBJ_GV_TIPAS")]
        public string ObjType { get; set; }

        [Name("OBJ_NUMERIS")]
        public int ObjIdNum { get; set; }

        [Name("P+")]
        public double UsedElectricity { get; set; }

        [Name("PL_T")]
        public DateTime Date { get; set; }

        [Name("P-")]
        public double ProducedElectricity { get; set; }
    }
}

