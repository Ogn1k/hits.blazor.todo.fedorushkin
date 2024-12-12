using TodoServerApp.Data.interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<TaskItem> tasks { get; } = [
           new() {Id = 1, Title="Задача 1", Description="Описание задачи 1", CreatedDate=DateTime.Now},
		];
        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(tasks);
        }

		public Task SaveAsync(TaskItem item)
		{
			throw new NotImplementedException();
		}
	}
}
