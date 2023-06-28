<a name="readme-top"></a>
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />

<h3 align="center">Severino</h3>

  <p align="center">
    Multi-assitant library
    <br />
    <a href=""><strong>Explore the docs »</strong></a>
    <br />
    <br />
    ·
    <a href="https://github.com/Jricard0/severino/issues">Report Bug</a>
    ·
    <a href="https://github.com/Jricard0/severino/issues">Request a Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

Severino (from the comedy show Zorra Total), is a set of helpers, validators and other codes that helps you to avoid duplicate unecessary code. Simple operations like validate environment vars, or send emails are part of Severino features.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

* [![Next][Next.js]][Next-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

This project is built using dotnet 6 and has all support to Nuget interface. All informations about release can be found [here](https://github.com/Jricard0/severino/releases)

### Prerequisites

Usually install using NuGet package manager (built-in on Microsoft Visual Studio) can be easier, BUT

Here is an example using **command line**:
```sh
dotnet add package Severino --version <pick-a-version>
```

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Coming soon...

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Features

### Validators:  
environment variables:
 - validate if a group of environment variables are defined
 - validate if a group of environment variables are defined, and check their value

### Helpers:  
Email:
 - Send email via SMTP (supports html body)

Password:
 - Encrypt password (using all supported kinds of Hash Types)
 - Generate password salt
 - Validate password

JWT:
 - Generate token
 - Validate token
 - Decode token

Middlewares:
*coming soon*
 
See the [open issues](https://github.com/Jricard0/cloudlib/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request for branch `main`

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

João Ricardo - [Twitter](https://twitter.com/xjricard)
email: joao.ricardo@odesenvolvedor.cloud

Project Link: [https://github.com/Jricard0/severino](https://github.com/Jricard0/severino)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/Jricard0/severino.svg?style=for-the-badge
[contributors-url]: https://github.com/Jricard0/severino/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Jricard0/severino.svg?style=for-the-badge
[forks-url]: https://github.com/Jricard0/severino/network/members
[stars-shield]: https://img.shields.io/github/stars/Jricard0/severino.svg?style=for-the-badge
[stars-url]: https://github.com/Jricard0/severino/stargazers
[issues-shield]: https://img.shields.io/github/issues/Jricard0/severino.svg?style=for-the-badge
[issues-url]: https://github.com/Jricard0/severino/issues
[license-shield]: https://img.shields.io/github/license/Jricard0/severino.svg?style=for-the-badge
[license-url]: https://github.com/Jricard0/severino/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/joão-ricardo-oliveira-silva
[product-screenshot]: images/screenshot.png
[Next.js]: https://img.shields.io/badge/.Net7-000000?style=for-the-badge&logo=dotnet6&logoColor=white
[Next-url]: https://learn.microsoft.com/pt-br/dotnet/core/whats-new/dotnet-6
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 