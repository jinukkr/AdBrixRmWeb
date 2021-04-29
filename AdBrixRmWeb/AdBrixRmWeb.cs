using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;


namespace AdBrixRmWeb
{
    public class AdBrixRmWeb
    {
        private static readonly IJSRuntime js;

        public static void Login(string userId)
        {
            js.InvokeVoidAsync("adbrix.login", userId);
        }

        public static async Task<string> GetUserId()
        {
            string userId = await js.InvokeAsync<string>("adbrix.getUserId");

            return userId;
        }

        public static void Logout()
        {
            js.InvokeVoidAsync("adbrix.logout");
        }

        public static void AddUserProperty(Dictionary<string, object> userProperty)
        {
            foreach (var values in userProperty)
            {
                js.InvokeVoidAsync("adbrix.userProperty.addOrUpdate", values.Key, values.Value);
            }
        }

        public static Task<object> GetAllUserProperty()
        {
            
        }

        public static Task<object> GetUserProperty(string propertyKey)
        {
            
        }

        public static void RemoveUserProperty(string propertyKey)
        {
            
        }

        public static void RemoveUserProperties(List<string> propertyKeys)
        {
            
        }

        public static void SignUp(AbxSignUpChannel signUpChannel)
        {
            
        }

        public static void UserInvite(AbxInviteChannel inviteChannel, string userId)
        {
            
        }

        public static void UseCredit(int creditAmount)
        {
            
        }
        
        public static object CommerceSetProduct(string productId, string productName, Double price, int quantity,
            Double discount, AbxCurrency currency, AbxCommerceCategory category,
            Dictionary<string, object> attr)
        {
            
        }
        
        public static object CommerceSetProduct(string productId, string productName, Double price, int quantity,
            Double discount, AbxCurrency currency, AbxCommerceCategory category)
        {
            
        }

        public static void CommonPurchase(string orderId, List<AbxProduct> productList, Double orderSale,
            Double discount, Double deliveryCharge, AbxPaymentMethod paymentMethod, Dictionary<string, object> attr)
        {
            
        }
        
        public static void CommonPurchase(string orderId, List<AbxProduct> productList, Double orderSale,
            Double discount, Double deliveryCharge, AbxPaymentMethod paymentMethod)
        {
            
        }
        
        public static void Event(string eventName)
        {
            
        }
        
        public static void Event(string eventName, Dictionary<string, object> attr)
        {
            
        }
        
    }
}