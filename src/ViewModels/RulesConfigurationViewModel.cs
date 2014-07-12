﻿// Papercut
// 
// Copyright © 2008 - 2012 Ken Robertson
// Copyright © 2013 - 2014 Jaben Cargman
//  
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//  
// http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Papercut.ViewModels
{
    using System.Collections.ObjectModel;

    using Caliburn.Micro;

    using Papercut.Core.Rules;
    using Papercut.Services;

    public class RulesConfigurationViewModel : Screen
    {
        readonly RuleService _ruleService;

        IRule _selectedRule;

        string _windowTitle = "Rules Configuration";

        public RulesConfigurationViewModel(RuleService ruleService)
        {
            _ruleService = ruleService;
            Rules = _ruleService.Rules;
        }

        public string WindowTitle
        {
            get { return _windowTitle; }
            set
            {
                _windowTitle = value;
                NotifyOfPropertyChange(() => WindowTitle);
            }
        }

        public IRule SelectedRule
        {
            get { return _selectedRule; }
            set
            {
                _selectedRule = value;
                NotifyOfPropertyChange(() => SelectedRule);
            }
        }

        public void AddForwardRule()
        {
            
        }

        public ObservableCollection<IRule> Rules { get; private set; }
    }
}