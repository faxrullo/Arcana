﻿using Arcana.Domain.Commons;
using Arcana.Domain.Enums.Levels;

namespace Arcana.Domain.Entities.Courses;

public class Course : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime Duration { get; set; }
    public int CountOfLessons { get; set; }
    public Level Level { get; set; }
    public long CategoryId { get; set; }
    public long InstructorId { get; set; }
    public long FileId { get; set; }
    //public long LanguageId {  get; set; }
}
