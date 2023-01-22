﻿using System.Threading.Tasks;
using ArknightsResources.Operators.Models;

namespace ArknightsResources.CustomResourceHelpers
{
    /// <summary>
    /// 定义一套用以获取与干员语音的方法
    /// </summary>
    public interface IOperatorVoiceGetter
    {
        /// <summary>
        /// 通过干员的配音信息获取其语音
        /// </summary>
        /// <param name="voiceInfo"></param>
        /// <returns></returns>
        byte[] GetOperatorVoice(OperatorVoiceItem voiceInfo);

        /// <summary>
        /// 通过干员的配音信息异步获取其语音
        /// </summary>
        /// <param name="voiceInfo"></param>
        /// <returns></returns>
        Task<byte[]> GetOperatorVoiceAsync(OperatorVoiceItem voiceInfo);
    }
}
