using System.Collections.Generic;

namespace MyBlazorApp.Models
{
    public class ProjectRepository
    {
        private static readonly List<Project> _projects = new List<Project>();

        public static List<Project> GetProjects()
        {
            _projects.Add(new Project
            {
                Id = 1,
                StartDate = new DateOnly(2005, 1, 15),
                EndDate = new DateOnly(2005, 1, 24),
                Name = "Bakers",
                Description = "Bathroom Remodel",
                Address1 = "228 Mystwood Cir",
                Address2 = "",
                City = "Holly Springs",
                State = "NC",
                PostalCode = "27540",
                CityImage = "holly-springs.jpg",
                HouseImage = "house1.jpg",
                IsResidential = true
            });

            _projects.Add(new Project
            {
                Id = 2,
                StartDate = new DateOnly(2015, 4, 18),
                EndDate = new DateOnly(2015, 5, 5),
                Name = "Millers",
                Description = "Interior Paint",
                Address1 = "38090 West Elm Street",
                Address2 = "Apartment 5B",
                City = "Holly Springs",
                State = "NC",
                PostalCode = "27540",
                CityImage = "holly-springs.jpg",
                HouseImage = "house2.jpg",
                IsResidential = true
            });

            _projects.Add(new Project
            {
                Id = 3,
                StartDate = new DateOnly(2023, 8, 13),
                EndDate = new DateOnly(2023, 8, 30),
                Name = "Hamilton",
                Description = "Bathroom Remodel",
                Address1 = "333 Pine Street",
                Address2 = "",
                City = "Wake Forest",
                State = "NC",
                PostalCode = "27587",
                CityImage = "wake-forest.jpg",
                HouseImage = "house3.jpg",
                IsResidential = true
            });

            _projects.Add(new Project
            {
                Id = 4,
                StartDate = new DateOnly(2013, 10, 15),
                EndDate = new DateOnly(2013, 10, 25),
                Name = "Maher",
                Description = "Kitchen Remodel",
                Address1 = "101 Royal Ave",
                Address2 = "",
                City = "St. Louis",
                State = "MO",
                PostalCode = "63135",
                CityImage = "st-louis.jpg",
                HouseImage = "house4.jpg",
                IsResidential = true
            });

            _projects.Add(new Project
            {
                Id = 5,
                StartDate = new DateOnly(2012, 6, 1),
                EndDate = new DateOnly(2012, 6, 11),
                Name = "Smith",
                Description = "Basement Finish",
                Address1 = "444 Elm Ave",
                Address2 = "",
                City = "St. Louis",
                State = "MO",
                PostalCode = "63135",
                CityImage = "st-louis.jpg",
                HouseImage = "house5.jpg",
                IsResidential = true
            });

            _projects.Add(new Project
            {
                Id = 6,
                StartDate = new DateOnly(2012, 9, 1),
                EndDate = new DateOnly(2012, 9, 13),
                Name = "Clarkson",
                Description = "Roof Repair",
                Address1 = "983 W Hwy 77",
                Address2 = "Building 7",
                City = "St. Louis",
                State = "MO",
                PostalCode = "63135",
                CityImage = "st-louis.jpg",
                HouseImage = "house7.jpg",
                IsResidential = false
            });

            return _projects;
        } 

        public static List<Project> GetProjectByCity(string city)
        {
            var filteredList = _projects.Where(p => p.City == city).ToList();
            return filteredList;
        }

        public static List<string> GetAllProjectCities()
        {
            var uniqueCities = _projects.Select(p => p.City).Distinct().ToList();
            return uniqueCities;
        }

        public static Project GetProjectById(int id)
        {
            Project project = _projects.FirstOrDefault(p => p.Id == id);
            return project;
        }
    }
}
