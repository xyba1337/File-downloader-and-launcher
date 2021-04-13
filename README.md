# File-downloader-and-launcher
Simple file bootstrapper which only uses .NET WebClient for it's entirety.
Use this only if you're trying to keep a small userbase updated, as a lot of people will have issues with the download due to the fact that the way of handling the download is not optimized well enough. Read more in -> Note

## Note

This is a very basic way of handling the downloadstream, a better variant would be to work with MemoryStream : System.IO.Stream, in order to prevent all sorts of memory leaks!
