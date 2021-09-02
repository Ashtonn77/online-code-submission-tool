using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeSubmissionTool.Shared;

namespace CodeSubmissionTool.Server.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Test> Tests { get;  }

        IGenericRepository<Submission> Submissions { get; }

        IGenericRepository<Question> Questions { get; }

        IGenericRepository<Challenge> Challenges { get; }

        IGenericRepository<UnitTest> UnitTests { get; }

        Task Save();

    }
}
