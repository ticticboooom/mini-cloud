<template>
  <div class="form-wrapper">
    <form class="login-form">
      <div class="form-header">Login</div>
      <div class="form-body">
        <div class="form-section">
          <label>Email Address</label>
          <input type="email" v-model="email" />
        </div>
        <div class="form-section">
          <label>Password</label>
          <input type="password" v-model="password" />
        </div>
        <div class="form-section">
          <button class="button-primary">Login</button>
        </div>
      </div>
      <div class="form-footer"></div>
    </form>
  </div>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";
import ApiService from "@/service/api-service";
@Component({})
export default class Login extends Vue {
  private email = "";
  private password = "";

  private submit() {
    ApiService.postLogin({ email: this.email, password: this.password }).then();
  }
}
</script>

<style scoped lang="scss">
.form-wrapper {
  display: inline-block;
  padding-top: 100px;
  margin: auto;
  .login-form {
    width: 400px;
    .form-header {
      font-family: neue-haas-unica, sans-serif;
      font-weight: 200;
      font-size: 22px;
      text-align: left;
      color: #ffffff;
      width: 100%;
      padding: 10px 20px;
      background-color: #2667ff;
      border-radius: 15px 15px 0 0;
    }
    .form-body {
      width: 100%;
      background-color: #fafafa;
      text-align: left;
      padding: 20px;
      .form-section {
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
      padding: 22px 20px;
      background-color: #2667ff;
      border-radius: 0 0 15px 15px;
    }
  }
}
</style>