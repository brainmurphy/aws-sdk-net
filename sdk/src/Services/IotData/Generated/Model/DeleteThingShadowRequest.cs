/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IotData.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteThingShadow operation.
    /// Deletes the thing shadow for the specified thing.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_DeleteThingShadow.html">DeleteThingShadow</a>
    /// in the <i>AWS IoT Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteThingShadowRequest : AmazonIotDataRequest
    {
        private string _thingName;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing.
        /// </para>
        /// </summary>
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}