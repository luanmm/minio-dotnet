/*
 * MinIO .NET Library for Amazon S3 Compatible Cloud Storage, (C) 2017 MinIO, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Minio.Exceptions;

namespace Minio.DataModel;

[Serializable]
[XmlRoot(ElementName = "DeleteResult", Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
public class DeleteObjectsResult
{
    [XmlElement("Deleted")] public Collection<DeletedObject> ObjectsList { get; set; }
    [XmlElement("Error")] public Collection<DeleteError> ErrorList { get; set; }
}