namespace CompanyManagementAPI.Models {
    
    public class Project {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public string ProjectCode { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        
        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
