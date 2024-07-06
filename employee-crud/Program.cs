using employee_crud.Services;

namespace employee_crud
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var employeeService = new EmployeeService();
            ApplicationConfiguration.Initialize();
            Application.Run(new Dashboard(employeeService));
        }
    }
}