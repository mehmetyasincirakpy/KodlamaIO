﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
    void DeleteById(int id);
}
