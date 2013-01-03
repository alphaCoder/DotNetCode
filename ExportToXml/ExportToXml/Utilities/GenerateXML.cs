using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ExportToXml.Utilities
{
    public class GenerateXML
    {
        public static string GetXML()
        {
            var employees = GetEmployees();
            var declaration = new XDeclaration("1.0", "utf-8", "yes");
            var doc = new XDocument(declaration, employees);

            var writer = new StringWriter();
            doc.Save(writer);

            return writer.GetStringBuilder().ToString();
        }

        private static XElement GetEmployees()
        {
            var employees = new XElement("Employees");
            var emp1 = GetEmployee("Ram", "Chander");
            var emp2 = GetEmployee("Bhem", "Rao");
            var emp3 = GetEmployee("John", "Doe");
            var emp4 = GetEmployee("Tyler", "Wood");
            var emp5 = GetEmployee("Matt", "Alex");
            var emp6 = GetEmployee("Lauri", "Mac");

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);
            employees.Add(emp6);
            return employees;
        }

        private static XElement GetEmployee(string firstName, string lastName)
        {
            var employee = new XElement("Employee");
            employee.Add(GetNode("FirstName", firstName));
            employee.Add(GetNode("LastName", lastName));
            return employee;
        }

        private static XElement GetNode(string label, string value)
        {
            var node = new XElement(label, value);
            return node;
        }
    }
}