﻿using System;
using System.Linq;
using mysoap.Models;

namespace mysoap {
    public class Service1 : IService1 {
        public string GetData(int value) {
            
            using (CotocrafterEntities rs = new CotocrafterEntities()) {
                try {
                    var result = rs.SelectProcedure(value).First<string>();
                    return result;
                }
                catch (Exception e) {
                    return e.Message;
                }
                
            }
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite) {
            if (composite == null) {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue) {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}