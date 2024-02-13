﻿namespace AspNetCoreEmpity.Models.Entities
{
    public class Size
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SmallName { get; set; }
        public DateTime CreateAt { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
