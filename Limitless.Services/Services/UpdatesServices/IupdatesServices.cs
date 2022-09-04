﻿using System;
using System.Collections.Generic;
using System.Text;
using Unit.Logic.Models;

namespace Limitless.Services.Services.UpdatesServices
{
  public interface IupdatesServices
    {
        public ResultViewModel GetMainUpdates();
        public ResultViewModel GetDetailsOfUpdates(int DetailId);
        public ResultViewModel GetMainUpdates_Ar();
        public ResultViewModel GetDetailsOfUpdates_Ar(int DetailId);
    }
}