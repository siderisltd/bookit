namespace BookIt.Data.Common
{
    using System.Collections.Generic;

    public class ConstantRoles
    {
        public const string ADMIN_ROLE = "Admin";
        public const string CREATOR_ROLE = "Creator";
        public const string EMPLOYEE_ROLE = "Employee";
        public const string OWNER_ROLE = "Owner";
        public const string MANAGER_ROLE = "Manager";
        public const string SUPERVISOR_ROLE = "Supervisor";
        public const string WORKER_ROLE = "Worker";

        public static readonly HashSet<string> allRoles = new HashSet<string>()
        {
            ADMIN_ROLE,
            CREATOR_ROLE,
            EMPLOYEE_ROLE,
            OWNER_ROLE,
            MANAGER_ROLE,
            SUPERVISOR_ROLE,
            WORKER_ROLE
        };

        
    }
}
