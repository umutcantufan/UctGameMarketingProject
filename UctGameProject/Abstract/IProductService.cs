using System;
using System.Collections.Generic;
using System.Text;
using UctGameProject.Entities;

namespace UctGameProject.Abstract
{
    interface IProductService
    {
        void Add(Products products);
        void Update(Products products);
        void Delete(Products products);

    }
}
