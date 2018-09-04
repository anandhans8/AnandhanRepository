namespace AnandhanRepository.Repository
{
    public static class RepositoryFactory
    {
        public static TRepository Create<TRepository>() where TRepository: class
        {
            if (typeof(TRepository) == typeof(IEmployeeRepository))
            {
                return new EmployeeXMLRepository() as TRepository;
            }
            return null;
        }
    }
}