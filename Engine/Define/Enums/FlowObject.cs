using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF.Engine.Define.AttachData;

namespace WF.Engine.Define.Enums
{
    /// <summary>
    /// 事件类型
    /// </summary>
    /// <remarks>Wang 20161128</remarks>
    /// <returns></returns>
    public enum Event
    {
        [AttachData(AttachDataKey.Description, "普通事件")]
        NoneEvent = 0,
        [AttachData(AttachDataKey.Description, "定时事件")]
        TimeEvent = 1,
        [AttachData(AttachDataKey.Description, "消息事件")]
        MessageEvent = 2,
        [AttachData(AttachDataKey.Description, "信号事件")]
        SignalEvent = 3,
        [AttachData(AttachDataKey.Description, "条件事件")]
        ConditionalEvent = 5,
        [AttachData(AttachDataKey.Description, "链接事件")]
        LinkEvent = 6,
        [AttachData(AttachDataKey.Description, "多重事件")]
        MultipleEvent = 7,
        [AttachData(AttachDataKey.Description, "并行多重事件")]
        ParallelMultipleEvent = 8,
        [AttachData(AttachDataKey.Description, "出错事件")]
        ErrorEvent = 9,
        [AttachData(AttachDataKey.Description, "补偿事件")]
        CompensationEvent = 10,
        [AttachData(AttachDataKey.Description, "取消事件")]
        CancelEvent = 11,
        [AttachData(AttachDataKey.Description, "升级事件")]
        EscalationEvent = 12
    }

    /// <summary>
    /// 事件状态
    /// </summary>
    /// <remarks>Wang 20161128</remarks>
    /// <returns></returns>
    public enum EventType
    {
        [AttachData(AttachDataKey.Description, "开始")]
        Start = 0,
        [AttachData(AttachDataKey.Description, "开始事件子流程中断")]
        StartEventSubProcessInterrupting = 1,
        [AttachData(AttachDataKey.Description, "开始事件子流程非中断")]
        StartEventSubProcessNonInterrupting = 2,
        [AttachData(AttachDataKey.Description, "中间捕获")]
        InterCatching = 3,
        [AttachData(AttachDataKey.Description, "中间抛出")]
        InterThrowing = 4,
        [AttachData(AttachDataKey.Description, "中间边界中断")]
        InterBoundaryInterrupting = 5,
        [AttachData(AttachDataKey.Description, "中间边界非中断")]
        InterBoundaryNonInterrupting = 6,
        [AttachData(AttachDataKey.Description, "结束")]
        End = 7
    }

    /// <summary>
    /// 活动类型
    /// </summary>
    /// <remarks>Wang 20161128</remarks>
    /// <returns></returns>
    public enum Activity
    {
        // 任务类型，0-19
        [AttachData(AttachDataKey.Description, "任务")]
        Task = 0,
        [AttachData(AttachDataKey.Description, "普通任务")]
        NoneTask = 1,
        [AttachData(AttachDataKey.Description, "人工任务")]
        UserTask = 2,
        [AttachData(AttachDataKey.Description, "手工任务")]
        ManualTask = 3,
        [AttachData(AttachDataKey.Description, "发送任务")]
        SendTask = 4,
        [AttachData(AttachDataKey.Description, "接收任务")]
        ReceiveTask = 5,
        [AttachData(AttachDataKey.Description, "业务规则任务")]
        BusinessRuleTask = 6,
        [AttachData(AttachDataKey.Description, "脚本任务")]
        ScriptTask = 7,
        [AttachData(AttachDataKey.Description, "服务任务")]
        ServiceTask = 8,

        // 子流程类型，20-39
        [AttachData(AttachDataKey.Description, "子流程")]
        SubProcess = 20,
        [AttachData(AttachDataKey.Description, "可嵌入子流程")]
        EmbeddedSubProcess = 21,
        [AttachData(AttachDataKey.Description, "可重用子流程")]
        ReusableSubProcess = 22,
        [AttachData(AttachDataKey.Description, "事件子流程")]
        EventSubProcess = 23,
        [AttachData(AttachDataKey.Description, "事物性子流程")]
        Transaction = 24,
        [AttachData(AttachDataKey.Description, "即席子流程")]
        AdHocSubProcess = 25,

        // 调用活动，40
        [AttachData(AttachDataKey.Description, "调用活动")]
        CallActivity = 40
    }

    /// <summary>
    /// 网关
    /// </summary>
    /// <remarks>Wang 20161128</remarks>
    /// <returns></returns>
    public enum Gateway
    {
        [AttachData(AttachDataKey.Description, "排他网关")]
        ExclusiveGateway = 0,
        [AttachData(AttachDataKey.Description, "并发网关")]
        ParallelGateway = 1,
        [AttachData(AttachDataKey.Description, "包容性网关")]
        InclusiveGateway = 2,
        [AttachData(AttachDataKey.Description, "复杂网关")]
        ComplexGateway = 3,
        [AttachData(AttachDataKey.Description, "事件网关")]
        EventGateway = 4,
        [AttachData(AttachDataKey.Description, "排他事件网关")]
        ExclusiveEventGateway = 5,
        [AttachData(AttachDataKey.Description, "并发事件网关")]
        ParallelEventGateway = 6
    }
}
