namespace CompanyManagementAPI.Models {
    
    public class EmployeeProject {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public string Role { get; set; }

        public class EmployeeProjectPK {
            public int EmployeeId { get; set; }
            public int ProjectId { get; set; }
        }
    }
}
