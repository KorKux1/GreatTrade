﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTrade.Models
{
    public abstract class ObjectBase {

        public virtual int Id { get; set; }

    }
}
