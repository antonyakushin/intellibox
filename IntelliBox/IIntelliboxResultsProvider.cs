﻿/*
Copyright (c) 2010 Stephen P Ward and Joseph E Feser

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
*/
using System.Collections.Generic;

namespace System.Windows.Controls {

    /// <summary>
    /// Defines the interface contract between an <see cref="IntelliBox"/> and its <see cref="IntelliBox.DataProvider" />.
    /// </summary>
    public interface IIntelliboxResultsProvider {

        /// <summary>
        /// Tell the <see cref="IIntelliboxResultsProvider" /> to begin searching for the <paramref name="searchTerm"/>. Use the <paramref name="whenDone"/>
        /// parameter to give the results back to the <see cref="IntelliBox" /> when the search is completed. The <see cref="DateTime" />
        /// parameter to the <paramref name="whenDone"/> action should be the <paramref name="startTimeUtc"/> parameter.
        /// </summary>
        /// <param name="searchTerm">The text in the search box at the time the search was requested.</param>
        /// <param name="maxResults">The maximum number of search results the <see cref="IntelliBox"/> wants returned.</param>
        /// <param name="extraInfo">This is the value of the Tag property of the <see cref="IntelliBox"/> control at the time the search was started. Use the Tag property to pass any custom data to your <see cref="IIntelliboxResultsProvider" />.</param>
        IEnumerable<object> DoSearch(string searchTerm, int maxResults, object extraInfo);

    }
}
