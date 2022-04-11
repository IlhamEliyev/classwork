using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine.Models
{
    class Medicine
    {
        private int _id;
        public int Id { get => _id; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
