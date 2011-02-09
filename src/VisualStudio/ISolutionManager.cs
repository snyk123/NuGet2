using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EnvDTE;

namespace NuGet.VisualStudio {
    public interface ISolutionManager {

        /// <summary>
        /// Raised when the collection of projects in the current solution changes
        /// </summary>
        event EventHandler ProjectCollectionChanged;

        event EventHandler SolutionOpened;
        event EventHandler SolutionClosing;

        string SolutionDirectory { get; }

        string DefaultProjectName { get; set; }
        Project DefaultProject { get; }

        Project GetProject(string projectName);

        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "This is an expensive operation")]
        IEnumerable<Project> GetProjects();

        bool IsSolutionOpen { get; }
    }
}
