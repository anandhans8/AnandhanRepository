namespace AnandhanRepository.Repository
{
    public static class RepositoryFactory
    {
        public static TRepository Create<TRepository>(ContextTypes ctype) where TRepository: class
        {
            switch (ctype)
            {
                // case ContextTypes.EntityFramework:
                //     if (typeof(TRepository) == typeof(IStudentRepository))
                //     {
                //         return new StudentEFRepository() as TRepository;
                //     }
                //     return null;
                case ContextTypes.XMLSource:
                    if (typeof(TRepository) == typeof(IEmployeeRepository))
                    {
                        return new EmployeeXMLRepository() as TRepository;
                    }
                    return null;
                default:
                    return null;
            }
        }
    }
}