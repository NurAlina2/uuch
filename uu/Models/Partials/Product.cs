﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uu.Models
{
    public partial class Product
    {
        public string FullName
        {
            get
            {
                return $"Name: {Name} Price: {Price} ";
            }
        }
        public byte[] mainPhoto
        {
            get
            {
                var firstPhoto = this.ProductPhoto.FirstOrDefault();
                if (firstPhoto != null)
                {
                    return firstPhoto.Image;

                }
                return null;
            }
        }
    }
}
