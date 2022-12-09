using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationApp.Model
{
    class ProjectsManager
    {
        List<ProjectsClass> AllProjects;
        public ProjectsManager()
        {
            AllProjects = new List<ProjectsClass>();
        }
        
        public ProjectsClass GetFirstProject()
        {

            return AllProjects[0];
        }


        public void AddNewProject() 
        {
            ProjectsClass bob = new ProjectsClass();
            AllProjects.Add(bob);
        }

    }
}
