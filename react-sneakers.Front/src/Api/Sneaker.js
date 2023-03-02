import axios from "axios";

export default class AboutPost {
    
    static async getAll() {
        const response = await axios.get(`https://localhost:7217/api/Sneaker`);
        return response.data;
    }

    static async getById(id) {
        const response = await axios.get(`https://localhost:7217/api/Sneaker/${id}`);
        return response.data;
    }

    static async post(sneaker) {
        const response = await axios.post(`https://localhost:7217/api/Sneaker`,sneaker,{
            headers: {
              'Content-Type': 'application/json',
            }});
        return response.data;
    }

    static async put(sneaker){
        const response = await axios.put(`https://localhost:7217/api/Sneaker`,sneaker,{
            headers: {
              'Content-Type': 'application/json',
            }});
        return response.data;
    }

    static async DeleteById(id) {
        await axios.delete(`https://localhost:7217/api/Sneaker/${id}`);
    }
}