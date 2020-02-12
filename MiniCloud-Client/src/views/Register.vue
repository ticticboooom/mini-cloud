<template>
  <div class="form-wrapper">
    <form class="login-form" @submit.prevent="submit()">
      <div class="form-header">Register</div>
      <div class="form-body">
        <div class="form-section clearfix">
          <div class="form-section-half">
            <label>First Name</label>
            <input type="text" v-model="firstName" />
          </div>
          <div class="form-section-half">
            <label>Last Name</label>
            <input type="text" v-model="lastName" />
          </div>
        </div>
        <div class="form-section">
          <label>Email Address</label>
          <input type="text" v-model="email" />
        </div>
        <div class="form-section">
          <label>Password</label>
          <input type="text" v-model="password" />
        </div>
        <div class="form-section">
          <button class="button-primary">Register</button>
        </div>
      </div>
    </form>
  </div>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";
import ApiService from "@/service/api-service";
@Component({})
export default class Login extends Vue {
  private firstName = "";
  private lastName = "";
  private email = "";
  private password = "";


  private submit() {
    ApiService.postRegister({ firstName: this.firstName, lastName: this.lastName, email: this.email, password: this.password });
  }
}
</script>

<style scoped lang="scss">
.form-wrapper {
  display: inline-block;
  padding-top: 100px;
  margin: auto;
  .login-form {
    width: 600px;
    .form-header {
      font-family: neue-haas-unica, sans-serif;
      font-weight: 200;
      font-size: 22px;
      text-align: left;
      color: #000000;
      width: 100%;
      padding: 20px 40px;
      border-radius: 5px 5px 0 0;
      background-color: #fafafa;
      border: 1px solid #dedede;
    }
    .form-body {
      border: 1px solid #dedede;
      border-top: none;
      width: 100%;
      background-color: #fafafa;
      text-align: left;
      padding: 20px;
      .form-section {
        .form-section-half {
          width: 50%;
          float: left;
          &:first-of-type {
            padding-right: 15px;
          }
          &:last-of-type {
            padding-left: 15px;
          }
        }
        label {
          font-family: upgrade, sans-serif;
          font-weight: 200;
        }
        input {
          padding: 5px 10px;
          width: 100%;
        }
        padding: 20px 20px 20px 20px;
      }
    }
    .form-footer {
      font-family: neue-haas-unica, sans-serif;
      color: #ffffff;
      font-weight: 300;
      padding: 22px 20px;
      background-color: #2667ff;
      border-radius: 0 0 15px 15px;
    }
  }
}
</style>