import Axios from "axios";
import React, { Component } from 'react'

export class projectservices
{
    static customerurl = "http://localhost:5020/Customer";
    static Agenturl = "http://localhost:5020/Agents";
    static getCustomer = (id)=>{
        let geturl = `${this.customerurl}/${id}`;
        return Axios.get(geturl);
    }
    static getAgent = (id) =>{
        let geturl = `${this.Agenturl}/${id}`;
        return Axios.get(geturl);
    }
    static AddCustomer = (emp) =>{
        return Axios.post(this.AgentUrl,emp);
    }
    static AddAgent = (emp) =>{
        return Axios.post(this.Agenturl,emp)
    }
    static updateCustomer=(emp)=>{
        return Axios.put(this.customerurl,emp);
    }
    static updateAgent=(emp)=>{
        return Axios.put(this.Agenturl,emp);
    }

}
