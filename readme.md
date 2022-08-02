# Dotnet Shared Controllers

This project is an example of two api's reusing the same controller from a shared library. This is helpful if you want to make two BFF's (Backend for Frontend). You want one api to match the other, but have some extensions.

For example:
You have a public api, which your api partners can use, but for your own application you want to extend this api a little for some specific cases, but you don't want to expose this to partners.

By deploying a second api, that looks simular, but extends the public api with the extra bits for app use. It would also allow you to quickly add something to both api's by moving it from the specific project into the shared project.