using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace svc_G
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        DataClasses1DataContext db = new DataClasses1DataContext();
        public bool Login(string email, string password)
        {
            var webUser = (from u in db.UserTables where u.UserName.Equals(email) && u.UserPassword.Equals(password)
                           select u).FirstOrDefault();

            if(webUser != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public UserTable getUser(string email)
        {
            var vis = (from u in db.UserTables where u.UserName.Equals(email) select u).FirstOrDefault();
            if (vis != null)
            {
                var userAcc = new UserTable()
                {
                    UserId = vis.UserId,
                    UserName = vis.UserName,
                    UserSurname = vis.UserSurname,
                    UserEmail = vis.UserEmail,
                    UserType = vis.UserType
                };
                return userAcc;
            }

            return null;
        }

        public Review getReview(int proId)
        {
            var vis = (from u in db.Reviews where u.ProId.Equals(proId) select u).FirstOrDefault();
            if (vis != null)
            {
                var userAcc = new Review()
                {
                    review1 = vis.review1
                };
                return userAcc;
            }

            return null;
        }

        public UserTable Registeration(string name, string surname, string email, string password,string userType)
        {
            var newUser = new UserTable
            {

                UserName = name,
                UserSurname = surname,
                UserEmail = email,
                UserPassword = password,
                UserType = userType,
            };
            db.UserTables.InsertOnSubmit(newUser);
            try
            {
                db.SubmitChanges();
                return newUser;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return newUser;
            }
        }

        public bool editUser(string name, string surname, string email, string password)
        {
            var user = (from u in db.UserTables where u.UserName.Equals(name) && u.UserSurname.Equals(surname) 
                        && u.UserEmail.Equals(email)select u).FirstOrDefault();

            user.UserPassword = password;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }

        public Product AddProduct(string name, string description, string category, int price, string image)
        {
            var newProduct = new Product
            {
                ProName = name,
                ProPrice = price,
                ProDescription = description,
                ProCategory = category,
                ProImage = image
            };
            db.Products.InsertOnSubmit(newProduct);
            try
            {
                db.SubmitChanges();
                return newProduct;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return newProduct;
            }
        }

        public Product getProduct(string name)
        {
            var pro = (from u in db.Products select u).FirstOrDefault();

            var product = new Product
            {

                ProName = pro.ProName,
                ProDescription = pro.ProDescription,
                ProCategory = pro.ProCategory,
                ProPrice = pro.ProPrice,
                ProImage = pro.ProImage
            };
            return product;

        }

        public bool deleteProduct(int Pro, int Id)
        {
            var delete = (from u in db.Carts where u.CartId.Equals(Pro) && u.UserId.Equals(Id) select u).FirstOrDefault();

            if (delete != null)
            {
                db.Carts.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool editProduct(string name, int price, string description, string category, string image)
        {
            var pro = (from a in db.Products where a.ProName.Equals(name)
                       select a).FirstOrDefault();

            //pro.ProPrice = price;
            pro.ProName = name;
            pro.ProImage = image;
            pro.ProPrice = price;
            pro.ProCategory = category;
            pro.ProDescription = description;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();
                return false;
            }
        }

        public List<Product> getAllProducts()
        {
            dynamic pro = (from u in db.Products select u).DefaultIfEmpty();

            var listofProducts = new List<Product>();
            if (pro != null)
            {
                foreach (Product p in pro)
                {
                    var P = new Product
                    {
                        ProId = p.ProId,
                        ProName = p.ProName,
                        ProDescription = p.ProDescription,
                        ProCategory = p.ProCategory,
                        ProImage = p.ProImage,
                        ProPrice = p.ProPrice
                    };
                    listofProducts.Add(P);
                }
                return listofProducts;
            }
            else
            {
                return null;
            }
        }

        public void removeCart(int itemId, int userId)
        {
            var wish = (from u in db.Carts where u.UserId.Equals(userId)
                        select u).FirstOrDefault();

            db.Carts.DeleteOnSubmit(wish);
            db.SubmitChanges();

        }
        
        public void removeAsAdmin(string name)
        {
            var del = (from u in db.Products
                        where u.ProName.Equals(name)
                        select u).FirstOrDefault();

            db.Products.DeleteOnSubmit(del);
            db.SubmitChanges();

        }

        public Product GetProductWithId(int productId)
        {

            //retrieving product
            var prod = (from u in db.Products where u.ProId.Equals(productId) select u).FirstOrDefault();

            Product ProxP = null;
            if (prod != null)
            {

                var product = new Product()
                {
                    ProId = prod.ProId,
                    ProName = prod.ProName,
                    ProPrice = prod.ProPrice,
                    ProCategory = prod.ProCategory,
                    ProDescription = prod.ProDescription,
                };
                ProxP = product;
            }

            return ProxP;

        }

        public CartItem addTotCart(int productId, int clientId, int quantity)
        {
            var item = (from u in db.CartItems where u.ProId.Equals(productId) select u).DefaultIfEmpty();
            var cart = (from u in db.Carts where u.UserId.Equals(clientId) select u).DefaultIfEmpty();

            if (item == null)
            {
                var i = new CartItem()
                {
                    ProId = productId,
                    Quantity = quantity
                };
                return i;
            }
            else
            {
                return null;
            }
        }

        public bool addToCart(int productId, int clientId, int quantity)
        {

            var cartAccess = (from v in db.Carts where v.UserId.Equals(clientId) select v).FirstOrDefault();
            var product = (from v in db.Products where v.ProId.Equals(productId) select v).FirstOrDefault();

            if (cartAccess == null)
            {
                dynamic cart = new Cart()
                {
                    UserId = product.ProId,
                    TotalCost = (int)product.ProPrice
                };

                db.Carts.InsertOnSubmit(cart);

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                }

                cartAccess = cart;
            }
            else
            {
                //update cart total
                int total = getCartTotal(clientId);
                int price = (int)product.ProPrice;
                int newTotal = total + price;
                cartAccess.TotalCost = newTotal;

                try
                {
                    db.SubmitChanges();

                }
                catch (Exception e)
                {
                    e.GetBaseException();
                }


            }


            //add to cartItem

            if (cartAccess != null)
            {
                var cartItem = new CartItem()
                {
                    ProId = productId,
                    CartId = cartAccess.CartId,
                    Quantity = quantity

                };

                db.CartItems.InsertOnSubmit(cartItem);

                try
                {
                    db.SubmitChanges();

                    return true;
                }
                catch (Exception e)
                {
                    e.GetBaseException();
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public List<CartItem> listCartItemProducts(int usesrId)
        {
            //get cart
            var cart = (from u in db.Carts where u.UserId.Equals(usesrId) select u).FirstOrDefault();

            //get cart_items
            dynamic cartItemList = null;
            if (cart != null)
            {

                cartItemList = (from u in db.CartItems where u.CartId.Equals(cart.CartId) select u).DefaultIfEmpty();
            }


            //return cartItems for the specified cart
            if (cartItemList != null)
            {
                var list = new List<CartItem>();

                foreach (CartItem c in cartItemList)
                {
                    var cartItem = new CartItem()
                    {
                        CartId = c.CartId,
                        ProId = c.ProId,
                        ItemId = c.ItemId,
                        Quantity = c.Quantity
                    };

                    list.Add(cartItem);
                }

                return list;
            }
            else
            {
                return null;
            }


        }
        public Product GetImage(int productId)
        {
            var imageAcc = (from u in db.Products where u.ProId.Equals(productId) select u).FirstOrDefault();

            if (imageAcc != null)
            {
                var img = new Product()
                {
                    ProImage = imageAcc.ProImage
                };
                return img;
            }
            return null;
        }

        public int getCartTotal(int clientId)
        {
            var cart = (from u in db.Carts where u.UserId.Equals(clientId) select u).FirstOrDefault();

            if (cart != null)
            {
                return cart.TotalCost;
            }

            return 0;
        }

    }
}
