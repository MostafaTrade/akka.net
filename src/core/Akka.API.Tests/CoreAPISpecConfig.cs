﻿//-----------------------------------------------------------------------
// <copyright file="CoreAPISpecConfig.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2018 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2018 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using ApprovalTests.Reporters;
#if(DEBUG)
[assembly: UseReporter(typeof(DiffReporter), typeof(AllFailingTestsClipboardReporter))]
#else
[assembly: UseReporter(typeof(DiffReporter))]
#endif
