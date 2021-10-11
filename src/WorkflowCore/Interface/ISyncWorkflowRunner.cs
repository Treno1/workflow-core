using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WorkflowCore.Models;

namespace WorkflowCore.Interface
{
    public interface ISyncWorkflowRunner
    {
        Task<(WorkflowInstance, List<ExecutionError>)> RunWorkflowSync<TData>(string workflowId, int version, TData data, string reference, TimeSpan timeOut, bool persistSate = true)
            where TData : new();

        Task<(WorkflowInstance, List<ExecutionError>)> RunWorkflowSync<TData>(string workflowId, int version, TData data, string reference, CancellationToken token, bool persistSate = true)
            where TData : new();
    }
}