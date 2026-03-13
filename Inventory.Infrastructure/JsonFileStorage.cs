using Inventory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure
{
    internal class JsonFileStorage : IFileStorageService
    {
        /// <summary>
        /// 异步读取指定路径的文件内容。
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="cancellationToken">取消令牌</param>
        /// <returns>文件内容字符串</returns>
        public async Task<string> GetFileAsync(string filePath, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException(nameof(filePath));

            // 使用 UTF-8 编码读取文件内容
            return await File.ReadAllTextAsync(filePath, Encoding.UTF8, cancellationToken);
        }

        /// <summary>
        /// 异步将字符串内容保存到指定路径的文件。
        /// </summary>
        /// <param name="fileText">要写入的文本内容</param>
        /// <param name="filePath">文件路径</param>
        /// <param name="cancellationToken">取消令牌</param>
        public async Task SaveFileAsync(string fileText, string filePath, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentNullException(nameof(filePath));

            // 如果内容为 null，则写入空字符串
            await File.WriteAllTextAsync(filePath, fileText ?? string.Empty, Encoding.UTF8, cancellationToken);
        }
    }
}
