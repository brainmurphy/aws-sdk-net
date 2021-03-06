/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Runtime.Serialization;

namespace System.IO {
    [Serializable()] 
	public sealed class InvalidDataException  : SystemException
    {
        public InvalidDataException ()
            : base() {
        }
 
        public InvalidDataException (String message)
            : base(message) {
        }
 
        public InvalidDataException (String message, Exception innerException)
            : base(message, innerException) {
        }
  
        internal InvalidDataException (SerializationInfo info, StreamingContext context) : base(info, context) {
        }
 
    }
}