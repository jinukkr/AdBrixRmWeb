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

        public static async Task<object> GetAllUserProperty()
        {
            return await js.InvokeAsync<object>("adbrix.userProperty.getAll");
        }

        public static async Task<object> GetUserProperty(string propertyKey)
        {
            return await js.InvokeAsync<object>("dbrix.userProperty.get", propertyKey);
        }

        public static void RemoveUserProperty(string propertyKey)
        {
            js.InvokeVoidAsync("adbrix.userProperty.remove",propertyKey);
        }

        public static void RemoveUserProperties(List<string> propertyKeys)
        {
            js.InvokeVoidAsync("adbrix.userProperty.removes",propertyKeys);

        }

        public static void SignUp(AbxSignUpChannel signUpChannel)
        {
            string signUpChannelString = signUpChannel.ToString();
            js.InvokeVoidAsync("adbrix.common.signUp",signUpChannelString);

        }

        public static void UserInvite(AbxInviteChannel inviteChannel, string userId)
        {
            string inviteChannelString = inviteChannel.ToString();
            js.InvokeVoidAsync("adbrix.common.invite",inviteChannelString);

        }

        public static void UseCredit(int creditAmount)
        {
            js.InvokeVoidAsync("adbrix.common.useCredit",creditAmount);

        }
        
        public static void CommonPurchase(string orderId, List<AbxProduct> productList, Double orderSale,
            Double discount, Double deliveryCharge, AbxPaymentMethod paymentMethod, Dictionary<string, object> attr)
        {
            string paymentMethodString = paymentMethod.ToString();
            js.InvokeVoidAsync("adbrix.common.purchase",orderId,productList,orderSale,discount,deliveryCharge,paymentMethodString,attr);

        }
        
        public static void CommonPurchase(string orderId, List<AbxProduct> productList, Double orderSale,
            Double discount, Double deliveryCharge, AbxPaymentMethod paymentMethod)
        {
            string paymentMethodString = paymentMethod.ToString();
            js.InvokeVoidAsync("adbrix.common.purchase",orderId,productList,orderSale,discount,deliveryCharge,paymentMethodString);
        }
        
        public static void Event(string eventName)
        {
            js.InvokeVoidAsync("adbrix.event.send",eventName);

        }
        
        public static void Event(string eventName, Dictionary<string, object> attr)
        {
            js.InvokeVoidAsync("adbrix.event.send",eventName,attr);

        }
        
    }
}