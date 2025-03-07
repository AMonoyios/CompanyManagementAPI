namespace CompanyManagementAPI.Models {
    
    public class Department {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OfficeLocation { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
