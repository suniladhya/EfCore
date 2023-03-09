// See https://aka.ms/new-console-template for more information

using PublisherData;

using (PubContext context = new PubContext())
{
    context.Database.EnsureCreated();
}
