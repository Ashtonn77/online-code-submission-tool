using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeSubmissionTool.Server.Data;
using CodeSubmissionTool.Server.IRepositories;
using CodeSubmissionTool.Shared;

namespace CodeSubmissionTool.Server.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private IGenericRepository<Test> _tests;
        private IGenericRepository<Submission> _submissions;
        private IGenericRepository<Question> _questions;
        private IGenericRepository<Challenge> _challenges;
        private IGenericRepository<UnitTest> _unitTests;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Test> Tests => _tests ??= new GenericRepository<Test>(_context);

        public IGenericRepository<Submission> Submissions =>
            _submissions ??= new GenericRepository<Submission>(_context);

        public IGenericRepository<Question> Questions => _questions ??= new GenericRepository<Question>(_context);

        public IGenericRepository<Challenge> Challenges => _challenges ??= new GenericRepository<Challenge>(_context);

        public IGenericRepository<UnitTest> UnitTests => _unitTests ??= new GenericRepository<UnitTest>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

    }
}
