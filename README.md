# FinalProject (TrainersShop)
## !!! SETUP STEPS !!! 
Update host file on your PC like this instruction: https://www.nublue.co.uk/guides/edit-hosts-file/#:~:text=In%20Windows%2010%20the%20hosts,%5CDrivers%5Cetc%5Chosts.

Need to path these lines

    127.0.0.1 www.alevelwebsite.com
    0.0.0.0 www.alevelwebsite.com
    192.168.0.4 www.alevelwebsite.com

### Docker
docker-compose build --no-cache

docker-compose up


## Additional info:
### Predefined users
**Login:** bob **Pass:** bob

**Login:** alice **Pass:** alice

### Swagger

**For catalog:** http://www.alevelwebsite.com:5000/swagger/index.html

**For basket:** http://www.alevelwebsite.com:5003/swagger/index.html

**For order:** http://www.alevelwebsite.com:5004/swagger/index.html

### pgAdmin
**Login:** user@domain.com **Pass:** postgres

**You need to register server first time:**

**Name**: any

**Host adress:** 192.168.0.4

**Username:** postgres

**Pass:** postgres

### Migrations

**Package manager console:** Add-Migration

**Terminal:** dotnet ef --startup-project Catalog/Catalog.Host migrations add InitialCreate --project Catalog/Catalog.Data

**Package manager console:** Update-Migration

**Terminal:** dotnet ef --startup-project Catalog/Catalog.Host database update InitialCreate --project Catalog/Catalog.Data

**Package manager console:** Remove-Migration

**Terminal:** dotnet ef --startup-project Catalog/Catalog.Host migrations remove --project Catalog/Catalog.Data -f


## Description:
The project contains 3 microservices that resemble the structure of a classic online store:
1. Catalog
2. Shopping cart
3. Order

Other components such as:
1. UI - Web MVC
2. DataBase Server - Postgre SQL
3. Provider Cache - Redis
4. Identity Provider - Identity Server 4
5. Proxy/Cdn - Nginx


StyleCop - connected

For all methods in services at least 2 unit tests.

Communication with the DB is contained in the repositories classes.

Business logic is wrapped in transactions if there was a place to work with DB.

Models(requests classes) are covered with validation attributes.

All business logic covered by logging.
