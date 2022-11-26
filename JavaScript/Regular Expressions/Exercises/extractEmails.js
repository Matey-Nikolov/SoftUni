function extractEmails(input) {
    //https://www.wired.com/2008/08/four-regular-expressions-to-check-email-addresses/
    let pattern = /([a-z0-9][-a-z0-9_\+\.]*[a-z0-9])@([a-z0-9][-a-z0-9\.]*[a-z0-9])/g;

    let matchesMail = [...input.matchAll(pattern)];

    matchesMail.forEach(mail => {
        console.log(mail[0]);
    });
}

extractEmails('Please contact us at: support@github.com.');
extractEmails('Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.');
extractEmails('Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.');