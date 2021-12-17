﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenters.IViews;
namespace Presenters {
    public class StartPresenter {
        IStartView _startView;
        public StartPresenter(IStartView startView) {
            _startView = startView;
        }
        public void Start() {
            _startView.Confirm();
        }
    }
}
