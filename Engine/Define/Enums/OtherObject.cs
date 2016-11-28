using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF.Engine.Define.AttachData;

namespace WF.Engine.Define.Enums
{
    /**
     * 连接对象
     * @Author
     */
    public enum ConnectObject
    {
        // 任务类型
        [AttachData(AttachDataKey.Description, "顺序流")]
        SequenceFlow = 0,
        [AttachData(AttachDataKey.Description, "消息流")]
        MessageFlow = 1,
        [AttachData(AttachDataKey.Description, "关联")]
        AssociationFlow = 2,
        [AttachData(AttachDataKey.Description, "数据关联")]
        DataAssociationFlow = 3
    }
    /**
     * 数据
     */
    public enum Data
    {
        // 任务类型
        [AttachData(AttachDataKey.Description, "数据对象")]
        DataObject = 0,
        [AttachData(AttachDataKey.Description, "数据输入")]
        DataInput = 1,
        [AttachData(AttachDataKey.Description, "数据输出")]
        DataOutput = 2,
        [AttachData(AttachDataKey.Description, "数据存储")]
        DataStore = 3
    }

    /**
     * 人工交付物，暂时不用 ！！！
     */
    public enum Artifact
    {
        // 任务类型
        [AttachData(AttachDataKey.Description, "组")]
        Group = 0,
        [AttachData(AttachDataKey.Description, "附注")]
        TextAnnotation = 1
    }

    /**
     * 泳道，暂时不用 ！！！
     */
    public enum Swimlanes
    {
        // 任务类型
        [AttachData(AttachDataKey.Description, "池")]
        Pool = 0,
        [AttachData(AttachDataKey.Description, "道")]
        Lane = 1
    }
}
