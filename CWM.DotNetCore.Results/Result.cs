using CWM.DotNetCore.ValidatR;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CWM.DotNetCore.Results
{
    public class Result
    {
        public Result(){}
        public List<string> Messages { get; set; } = new List<string>();
        public bool Succeeded { get; }
        internal Result(bool succeeded, List<string> messages = null)
        {
            Succeeded = succeeded;
            Messages = messages;
        }
        internal Result(bool succeeded, string message)
        {
            Succeeded = succeeded;
            Messages.Add(message);
        }
        public static Result Failure(List<string> messages)
        {
            Throw.Exception.IfNull(messages, nameof(messages));
            return new Result(false, messages);
        }
        public static Result Failure(string message) => new Result(false, message);
        public static Result Success() => new Result(true);
        public static Result Success(string message) => new Result(true, message);
        public static Result EntityCreated(int entityId, string entityName) => new Result(true, $"Entity {entityName} with Id {entityId} Created.");
        public static Result EntityDeleted(int entityId, string entityName) => new Result(true, $"Entity {entityName} with Id {entityId} Deleted.");
        public static Result EntityUpdated(int entityId, string entityName) => new Result(true, $"Entity {entityName} with Id {entityId} Updated.");
    }
    public class Result<T> : Result
    {
        public Result(T data)
        {
            Data = data;
        }
        public T Data { get; }
        internal Result(bool succeeded, T data = default, List<string> messages = null) : base(succeeded, messages) => Data = data;
        public static new Result<T> Failure(List<string> messages)
        {
            Throw.Exception.IfNull(messages, nameof(messages));
            return new Result<T>(false, default, messages);
        }
        public static Result<T> Success(T data) => new Result<T>(true, data);
       
    }
}
