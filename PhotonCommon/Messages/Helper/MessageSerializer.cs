// ********************************************************************************
// Copyright (C) 2016 Sebastian Kenter. All rights reserved.
//  
// Name    : MMOServer | PhotonCommon | MessageSerializer.cs
// Created : 2016-21-08 14:03
// Modified: 2016-21-08 14:12
// ********************************************************************************

using System.IO;
using Google.Protobuf;

namespace PhotonCommon.Messages.Helper
{
    /// <summary>
    ///     Helper class for serializing and deserializing of GPB-messages
    /// </summary>
    public static class MessageSerializer
    {
        /// <summary>
        ///     Desirializes a gives messages
        /// </summary>
        /// <typeparam name="T">The message type to be desezialized to</typeparam>
        /// <param name="inputStream">The byte encoded serialized input</param>
        /// <returns></returns>
        public static T DeserializeMessage<T>(byte[] inputStream) where T : class, IMessage<T>, new()
        {
            T result = new T();

            result.MergeFrom(inputStream);

            return result;
        }

        /// <summary>
        ///     Serializes a given GPB-Message to a byte array
        /// </summary>
        /// <param name="message">The message to be serialized</param>
        /// <returns>Byte array containing the serialized message</returns>
        public static byte[] SerializeMessage(IMessage message)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                message.WriteTo(outStream);
                return outStream.ToArray();
            }
        }
    }
}