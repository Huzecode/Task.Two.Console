using System;

namespace Task.Two.ConsoleCore.Services
{
    public class ServiceManager
    {
		static readonly Lazy<ServiceManager> instance = new Lazy<ServiceManager>(() => new ServiceManager());
		/// <summary>
		/// Singleton instance for default service locator
		/// </summary>
		public static ServiceManager Instance
		{
			get { return instance.Value; }
		}

		public ExcelOperations ExcelOperations { get => new ExcelOperations(); }
		public IntialDataGenerator IntialDataGenerator { get => new IntialDataGenerator(); }
		public FileStorage FileStorage { get => new FileStorage(); }
	}
}
