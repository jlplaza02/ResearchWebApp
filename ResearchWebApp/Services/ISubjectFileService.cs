﻿using ResearchWebApp.Models;

namespace ResearchWebApp.Services
{
    public interface ISubjectFileService
    {
        Task AddSubjectFileAsync(SubjectFile subjectFile);
        Task<IEnumerable<SubjectFile>> GetFilesBySubjectIdAsync(int subjectId);
        Task<SubjectFile> GetSubjectFileByIdAsync(int id);

        Task DeleteSubjectFileAsync(int Id);
    }
}
