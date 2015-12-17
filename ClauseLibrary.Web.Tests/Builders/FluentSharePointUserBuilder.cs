// Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.  
// See full license at the bottom of this file.

using ClauseLibrary.Common.Models;

namespace ClauseLibrary.Web.Tests.Builders
{
    public class FluentSharePointUserBuilder
    {
        private string _email = "clauselibrarytest@provoke.co.nz";
        private string _title = "Clause Library User";
        private static int _uniqueId = 1;

        public FluentSharePointUserBuilder WithEmail(string emailAddress)
        {
            _email = emailAddress;
            return this;
        }

        public FluentSharePointUserBuilder WithTitle(string title)
        {
            _title = title;
            return this;
        }

        public SharePointUser Build()
        {
            return new SharePointUser
            {
                EMail = _email,
                Title = _title
            };
        }

        public SharePointUser BuildExisting(int? id = null)
        {
            SharePointUser sharePointUser = Build();
            sharePointUser.Id = id.GetValueOrDefault(_uniqueId++);
            return sharePointUser;
        }
    }
}

#region License 
// ClauseLibrary, https://github.com/OfficeDev/clauselibrary 
//   
// Copyright 2015(c) Microsoft Corporation 
//   
// All rights reserved. 
//   
// MIT License: 
//   
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
// associated documentation files (the "Software"), to deal in the Software without restriction, including 
// without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
// copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the 
// following conditions: 
//   
// The above copyright notice and this permission notice shall be included in all copies or substantial 
// portions of the Software. 
//   
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
// LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT 
// SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN 
// ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE 
// USE OR OTHER DEALINGS IN THE SOFTWARE. 
#endregion