using BookApp.Components.Models;
using Microsoft.JSInterop;
using System.Text.Json;

namespace BookApp.Components.Services
{
    public class WishlistService
    {
        private readonly IJSRuntime _jsRuntime;
        private const string WishlistKey = "bookapp_wishlist";

        public WishlistService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<List<Book>> GetWishlist()
        {
            var json = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", WishlistKey);
            if (string.IsNullOrEmpty(json))
                return new List<Book>();

            return JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
        }

        public async Task AddToWishlist(Book book)
        {
            var wishlist = await GetWishlist();
            if (!wishlist.Any(b => b.Key == book.Key))
            {
                wishlist.Add(book);
                var json = JsonSerializer.Serialize(wishlist);
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", WishlistKey, json);
            }
        }

        public async Task RemoveFromWishlist(string bookKey)
        {
            var wishlist = await GetWishlist();
            var bookToRemove = wishlist.FirstOrDefault(b => b.Key == bookKey);
            if (bookToRemove != null)
            {
                wishlist.Remove(bookToRemove);
                var json = JsonSerializer.Serialize(wishlist);
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", WishlistKey, json);
            }
        }

        public async Task ClearWishlist()
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", WishlistKey);
        }
    }
}
