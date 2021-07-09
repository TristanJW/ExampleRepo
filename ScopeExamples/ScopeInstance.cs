using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleApp.ScopeExamples
{
    class ScopeInstance // This is the singleton design pattern
    {
        public bool boolTest = true;
        public static ScopeInstance _instance;

        /// <summary>
        /// If an instance hasn't been made yet, make one.
        /// You can use this instance throughout the whole time the app is running.
        /// You can get the instance everywhere which makes it very flexible.
        /// 
        /// DISCLAIMER: this is an easy way out just like a static variable (this is a whole static class basically). 
        /// Only use this for like settings or smth.
        /// </summary>
        public static ScopeInstance GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ScopeInstance();
            }
            return _instance;
        }

    }
}
