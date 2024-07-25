using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace svc_G
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool Login(string email, string password);

        [OperationContract]
        UserTable Registeration(string name, string username, string email, string password, string userType);

        [OperationContract]
        UserTable getUser(string email);

        [OperationContract]
        bool editUser(string name, string surname, string email, string password);


        [OperationContract]
        Product AddProduct(string name, string description, string category, int price, string image);

        [OperationContract]
        Product getProduct(string name);

        [OperationContract]
        List<Product> getAllProducts();

        [OperationContract]
        bool deleteProduct(int Pro, int Id);

        [OperationContract]
        bool editProduct(string name, int price, string decription, string category, string image);

        [OperationContract]
        void removeCart(int itemId, int userId);

        [OperationContract]
        Product GetProductWithId(int productId);

        [OperationContract]
        bool addToCart(int productId, int clientId, int quantity);

        [OperationContract]
        List<CartItem> listCartItemProducts(int usesrId);

        [OperationContract]
        Product GetImage(int productId);

        [OperationContract]
        int getCartTotal(int clientId);

        [OperationContract]
        void removeAsAdmin(string name);

        [OperationContract]
        Review getReview(int proId);

        [OperationContract]
        CartItem addTotCart(int productId, int clientId, int quantity);
    }
}
