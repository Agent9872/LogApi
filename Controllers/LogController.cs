using Microsoft.AspNetCore.Mvc;
using MyLibrary; // Import your library namespace
using System;
using System.Threading.Tasks;

namespace LogAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : ControllerBase
    {
        private readonly LogFileManager _logFileManager;

        public LogController()
        {
            // Initialize your LogFileManager instance
            _logFileManager = new LogFileManager();
        }

        [HttpGet("unique-errors")]
        public IActionResult GetUniqueErrors(string filePath)
        {
            // Call the corresponding function from your library
            var uniqueErrorCount = _logFileManager.CountUniqueErrors(filePath);
            return Ok(uniqueErrorCount);
        }

        [HttpGet("duplicated-errors")]
        public IActionResult GetDuplicatedErrors(string filePath)
        {
            // Call the corresponding function from your library
            var duplicatedErrorCount = _logFileManager.CountDuplicatedErrors(filePath);
            return Ok(duplicatedErrorCount);
        }

        [HttpPost("delete-archive")]
        public IActionResult DeleteArchiveFromPeriod(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Call the corresponding function from your library
                _logFileManager.DeleteArchiveFromPeriod(startDate, endDate);
                return Ok("Archives from the specified period have been deleted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error deleting archives: {ex.Message}");
            }
        }

        [HttpPost("archive-logs")]
        public IActionResult ArchiveLogsFromPeriod(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Call the corresponding function from your library
                _logFileManager.ArchiveLogsFromPeriod(startDate, endDate);
                return Ok($"Logs from the period {startDate.ToShortDateString()} to {endDate.ToShortDateString()} have been archived successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error archiving logs: {ex.Message}");
            }
        }

        [HttpPost("upload-logs")]
        public async Task<IActionResult> UploadLogsToRemoteServer(string[] filePaths, string remoteServerUrl)
        {
            try
            {
                // Call the corresponding function from your library
                await _logFileManager.UploadLogsToRemoteServerAsync(filePaths, remoteServerUrl);
                return Ok("Log files uploaded to remote server successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error uploading log files: {ex.Message}");
            }
        }

        [HttpPost("delete-logs")]
        public IActionResult DeleteLogsFromPeriod(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Call the corresponding function from your library
                _logFileManager.DeleteLogsFromPeriod(startDate, endDate);
                return Ok("Logs from the specified period have been deleted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error deleting logs: {ex.Message}");
            }
        }

        [HttpGet("count-total-logs")]
        public IActionResult CountTotalAvailableLogsInPeriod(DateTime startDate, DateTime endDate)
        {
            try
            {
                // Call the corresponding function from your library
                var totalLogs = _logFileManager.CountTotalAvailableLogsInPeriod(startDate, endDate);
                return Ok($"Total logs available in the specified period: {totalLogs}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error counting total logs: {ex.Message}");
            }
        }

        // Add endpoints for US-14 and US-15 if needed
    }
}
